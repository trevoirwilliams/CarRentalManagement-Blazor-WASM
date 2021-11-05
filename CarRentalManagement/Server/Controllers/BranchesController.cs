using CarRentalManagement.Client.Pages;
using CarRentalManagement.Shared.DocumentModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchesController : ControllerBase
    {
        private readonly IMemoryCache cache;
        private readonly CosmosClient cClient;
        private Container documentContainer;
        private const string PARTITION_KEY = "country";
        public BranchesController(IMemoryCache cache, CosmosClient cClient)
        {
            this.cache = cache;
            this.cClient = cClient;
            documentContainer = cClient.GetContainer("Branches", "Locations");
        }


        // GET: api/<BranchesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var branches = new List<Branch>();
            var branchDocuments = documentContainer.GetItemQueryIterator<Branch>();
            while (branchDocuments.HasMoreResults)
            {
                var branchesPages = await branchDocuments.ReadNextAsync();
                branches.AddRange(branchesPages.ToList());
            }
            return Ok(branches);
        }

        // GET: api/<BranchesController>/search/jamaica
        [HttpGet("search/{country}")]
        public async Task<IActionResult> SearchByCountry(string country)
        {
            var branches = new List<Branch>();

            var branchDocuments = documentContainer.GetItemQueryIterator<Branch>(
                requestOptions: new QueryRequestOptions { PartitionKey = new PartitionKey(country) });

            while (branchDocuments.HasMoreResults)
            {
                var branchesPages = await branchDocuments.ReadNextAsync();
                branches.AddRange(branchesPages.ToList());
            }
            return Ok(branches);
        }

        // GET api/<BranchesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BranchesController>
        [HttpPost]
        public async Task<IActionResult> Post(Branch branch)
        {
            branch.Id = System.Guid.NewGuid();
            await documentContainer.CreateItemAsync(branch, new PartitionKey(branch.Country));

            return NoContent();
        }

        // PUT api/<BranchesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Branch branch)
        {
            await documentContainer.UpsertItemAsync(branch);
            return NoContent();
        }

        // DELETE api/<BranchesController>/5
        [HttpDelete("{id}/{key}")]
        public async Task<IActionResult> Delete(string id, string key)
        {
            await documentContainer.DeleteItemAsync<Branch>(id, new PartitionKey(key));
            return NoContent();
        }
    }
}

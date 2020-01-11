using System.Collections.Generic;
using System.Threading.Tasks;
using CacheSample.Models;
using CacheSample.Services;
using Microsoft.AspNetCore.Mvc;

namespace CacheSample.Controllers
{
    [Route("api/cache-client")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IDataService _dataService;
        private ICacheService _cache;

        public ValuesController(IDataService data, ICacheService cache)
        {
            _dataService = data;
            _cache = cache;
        }

        [HttpGet("value/{id}")]
        public async Task<ActionResult<string>> GetValue(string id)
        {
            var key = $"{id}value";
            if (await _cache.HasCacheRecord(key))
            {
                return await _cache.FetchString(key);
            }
            var value = await _dataService.GetStringValueById(id);
            await _cache.WriteString(key, value);
            return value;
        }

        [HttpGet("values/{id}")]
        public async Task<IEnumerable<string>> GetValues(string id)
        {
            var key = $"{id}values";
            if (await _cache.HasCacheRecord(key))
            {
                return await _cache.FetchRecord<IEnumerable<string>>(key);
            }
            var value = await _dataService.GetStringListById(id);
            await _cache.WriteRecord(key, value);
            return value;
        }

        [HttpGet("record/{id}")]
        public async Task<ActionResult<DataRecord>> GetRecord(string id)
        {
            var key = $"{id}record";
            if (await _cache.HasCacheRecord(key))
            {
                return await _cache.FetchRecord<DataRecord>(key);
            }
            var value = await _dataService.GetRecordById(id);
            await _cache.WriteRecord(key, value);
            return value;
        }

        [HttpGet("records/{id}")]
        public async Task<IEnumerable<DataRecord>> Get(string id)
        {
            var key = $"{id}records";
            if (await _cache.HasCacheRecord(key))
            {
                return await _cache.FetchRecord<IEnumerable<DataRecord>>(key);
            }
            var value = await _dataService.GetRecordListById(id);
            await _cache.WriteRecord(key, value);
            return value;
        }
    }
}
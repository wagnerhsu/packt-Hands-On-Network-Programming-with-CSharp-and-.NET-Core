﻿using System.Collections.Generic;
using System.Threading.Tasks;
using FitnessApp.Models;
using FitnessApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Controllers
{
    [Route("api/fitness-app")]
    [ApiController]
    public class FitnessController : ControllerBase
    {
        private readonly IDataStoreClient _dataStore;

        public FitnessController(IDataStoreClient data)
        {
            _dataStore = data;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FitnessRecord>>> Get()
        {
            return await _dataStore.GetAllRecords();
        }

        [HttpGet("{title}")]
        public async Task<ActionResult<FitnessRecord>> GetRecord(string title)
        {
            return await _dataStore.GetRecordByTitle(title);
        }

        [HttpGet("type/{type}")]
        public async Task<ActionResult<IEnumerable<FitnessRecord>>> GetRecordsByType(string type)
        {
            return await _dataStore.GetRecordsByWorkoutType(type);
        }

        [HttpPost]
        public async Task<IActionResult> NewRecord([FromBody] FitnessRecord newRecord)
        {
            if (await _dataStore.WriteRecord(newRecord))
            {
                return Ok("new record successfully written");
            }
            return StatusCode(400);
        }

        [HttpPatch("{title}/comments")]
        public async Task<IActionResult> UpdateComment(string title, [FromBody] string newComments)
        {
            if (await _dataStore.UpdateRecord(title, newComments))
            {
                return Ok("record successfully updated");
            }
            return StatusCode(400);
        }

        [HttpDelete("{title}")]
        public async Task<IActionResult> Delete(string title)
        {
            if (await _dataStore.DeleteRecord(title))
            {
                return Ok("record successfully deleted");
            }
            return StatusCode(400);
        }
    }
}
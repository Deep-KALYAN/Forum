using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace APIActivite3.Controllers
{
    public interface IRubricController
    {
        /// <summary>
        /// To Get all Topics of All Rubrics
        /// </summary>
        /// <returns>Ok GetRubricsAndTopicsDetailResponseDTO or NotFound</returns>
        Task<IActionResult> GetAllRubricsTopics();

        /// <summary>
        /// To Get all Rubrics 
        /// </summary>
        /// <returns> OK GetRubricsResponseDTO or  NotFound</returns>
        Task<IActionResult> GetRubrics();

        /// <summary>
        /// To Get Topics(with Detail) by Rubric Id (from View)
        /// Deleted Topics Filtered in DB View
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>OK GetRubricsAndTopicsDetailResponseDTO or  NotFound</returns>
        Task<IActionResult> GetTopicsByRubricId([FromRoute] int id);
    }
}
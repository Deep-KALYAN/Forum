using APIActivite3.Utils;
using Domain.DTO.Requestes.Topics;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace APIActivite3.Controllers
{
    public interface ITopicController
    {
        /// <summary>
        /// To Create the New Topic
        /// </summary>
        /// <param name="newTopicDTO">CreateTopicRequestDTO</param>
        /// <param name="currentUserUtils">ICurrentUserUtils</param>
        /// <returns>TopicResponseDTO or BadRequest</returns>
        Task<IActionResult> CreateTopic([FromBody] CreateTopicRequestDTO newTopicDTO, [FromServices] ICurrentUserUtils currentUserUtils);

        /// <summary>
        /// To Delete the Topic by ID
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>NoContent or NotFound</returns>
        Task<IActionResult> DeleteTopic([FromRoute] int id);

        /// <summary>
        /// To Get Topic by Id
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>OK TopicResponseDTO or NotFound </returns>
        Task<IActionResult> GetTopicById([FromRoute] int id);

        /// <summary>
        /// To Get the Replies and Theirs Parents Replies with Detail(from View) by Topic Id
        /// Deleled Topics filtered in DB view
        /// Deleted Replies and Deleted Parent Replies texts Changed in BLL
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>GetTopicRepliesDetailResponseDTO or NotFound</returns>
        Task<IActionResult> GetTopicDetailById([FromRoute] int id);

        /// <summary>
        /// To Update the Topic
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="updateTopicDTO">UpdateTopicRequestDTO</param>
        /// <param name="currentUserUtils">ICurrentUserUtils</param>
        /// <returns>OK TopicResponseDTO or BadRequest</returns>
        Task<IActionResult> UpdateTopic([FromRoute] int id, [FromBody] UpdateTopicRequestDTO updateTopicDTO, [FromServices] ICurrentUserUtils currentUserUtils);
    }
}
using APIActivite3.Utils;
using Domain.DTO.Requestes.Replies;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace APIActivite3.Controllers
{
    public interface IReplyController
    {
        /// <summary>
        /// To Create the Reply
        /// </summary>
        /// <param name="newReply">CreateReplyRequestDTO</param>
        /// <returns>ReplyResponseDTO or BadRequest</returns>
        Task<IActionResult> CreateReply([FromBody] CreateReplyRequestDTO newReply);

        /// <summary>
        /// To Delete the Reply
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="currentUserUtils">ICurrentUserUtils</param>
        /// <returns>NoContent or NotFound</returns>
        Task<IActionResult> DeleteReply([FromRoute] int id, [FromServices] ICurrentUserUtils currentUserUtils);

        /// <summary>
        /// To get the reply by Id
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>OK ReplyResponseDTO or NotFound</returns>
        Task<IActionResult> GetReplyById([FromRoute] int id);

        /// <summary>
        /// To Update the reply
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="updateReply">UpdateReplyRequestDTO</param>
        /// <param name="currentUserUtils">ICurrentUserUtils</param>
        /// <returns></returns>
        Task<IActionResult> UpdateReply([FromRoute] int id, [FromBody] UpdateReplyRequestDTO updateReply, [FromServices] ICurrentUserUtils currentUserUtils);
    }
}
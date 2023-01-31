using Elearning.Core.Extensions;

namespace Elearning.Core.DTO.Request.ProfileCKCP
{
    public class ProfileCKCPCreateRequest
    {
        public string ProfileCKMa { get; set; }
        public string CPMa { get; set; }
        public int IsActive { get; set; }

        public string CreatorName { get; set; }
        public int Creator { get; set; }
    }
}

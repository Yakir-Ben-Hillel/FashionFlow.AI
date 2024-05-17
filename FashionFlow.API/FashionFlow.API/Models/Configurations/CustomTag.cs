using System.ComponentModel.DataAnnotations.Schema;

namespace FashionFlow.API.Models.Configurations
{
    public class CustomTag : BaseConfigurationEntity
    {
        [ForeignKey("CustomTagType")]
        public int TagTypeId { get; set; }
        public bool IsManDeparttment { get; set; }
        public bool IsWomanDeparttment { get; set; }
        public bool IsKidsDeparttment { get; set; }

    }
}

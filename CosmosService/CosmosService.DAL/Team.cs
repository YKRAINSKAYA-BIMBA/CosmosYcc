using System.ComponentModel.DataAnnotations;

namespace CosmosService.DAL
{
    public class Team
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Count { get; set; }
        public string Slogan { get; set; }
        public string EmblemName { get; set; }
        public byte[] EmblemFile { get; set; }

        /// <summary> Связь с игрой </summary>
        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}

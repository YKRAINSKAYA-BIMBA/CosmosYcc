using System;
using System.ComponentModel.DataAnnotations;

namespace CosmosService.DAL
{
    public class Fixation
    {
        public int Id { get; set; }
        [Required]
        public DateTime Start { get; set; }
        [Required]
        public DateTime Finish { get; set; }
        [Required]
        public int Score { get; set; }
        public int Fine { get; set; }
        public string Comment { get; set; }

        /// <summary> Связь с командой </summary>
        public int TeamId { get; set; }
        public Team Team { get; set; }

        /// <summary> Связь со станцией </summary>
        public int WorkplaceId { get; set; }
        public Workplace Workplace { get; set; }
    }
}

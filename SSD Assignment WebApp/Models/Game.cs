using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace SSD_Assignment_WebApp.Models
{
    public class Game
    {
        [Display(Name = "Game Id")]
        public int GameId { get; set; }

        [Display(Name = "Save File Name")]
        public string SaveFileName { get; set; }

        [Required]
        [Display(Name = "Turn Number")]
        public int TurnNo { get; set; }

        [Required]
        [Display(Name = "Coin Balance")]
        [Range(0, 100, ErrorMessage = "You ran out of coins")]
        public int CoinBal { get; set; }

        [Required]
        [Display(Name = "Score")]
        public int Score { get; set; }

        [Required]
        [Display(Name = "Map")]
        public List<List<GridSpace>> Map { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MyToDoList.Models;

namespace MyToDoList.Pages
{
    public class IndexModel : PageModel
    {
        
       
        public List<Models.Movie> Movies { get; set; }

        
        
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            
            _logger = logger;
        }

        // default method to get all todo items from database
        public void OnGet()
        {

            Movies = new List<Movie>
{
    new Movie{ Banner = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcSMOFEXNF--nfV2_o9L2APXysq3qoFZ3-XyZehDDEXiqh_EwZuA", Title = "The Last Samurai", Description="Set in Japan during the 1870s, this movie tells the story of Captain Nathan Algren (Tom Cruise), a respected American military officer hired by the Emperor of Japan to train the country's first Army in the art of modern warfare.", Duration="2 Hrs 10 mins" },
    new Movie{ Banner = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcQ4QYpWCQ5pareSyOO3YNI3YsOmAeF4qcRDwHCDwf3-a3F0Y7N6", Title = "Taxi Driver", Description="Suffering from insomnia, disturbed loner Travis Bickle (Robert De Niro) takes a job as a New York City cabbie, haunting the streets nightly, growing increasingly detached from reality as he dreams of cleaning up the filthy city" , Duration="2 Hrs 45 mins"},
    new Movie{ Banner = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcST5c7MHZYvb1kbcNPmMUlryVUew-pzc8E1QyPvqTlP1ik2IadY", Title = "Rang de Basanti", Description="After a group of friends graduate from Delhi University, they listlessly haunt their old campus, until a British filmmaker (Alice Patten) casts them in a film she's making about freedom fighters under British rule" , Duration = "2 Hrs 40 mins"},
    new Movie{ Banner = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSQqDJlY72hDYqFfWGnW3FjU4KVdAg73p56yxvjaRsKW0CHJmqr", Title = "Slumdog Millionaire", Description="As 18-year-old Jamal Malik (Dev Patel) answers questions on the Indian version of 'Who Wants to Be a Millionaire,' flashbacks show how he got there" , Duration = "2 Hrs 30 mins"},
    new Movie{ Banner = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcS93BIInWhD9_rzD2392tlqNV3MprG0_K7rLbGVWphiFJp3anf4", Title = "Shutter Island", Description="The implausible escape of a brilliant murderess brings U.S. Marshal Teddy Daniels (Leonardo DiCaprio) and his new partner (Mark Ruffalo) to Ashecliffe Hospital, a fortress-like insane asylum located on a remote, windswept island" , Duration = "2 Hrs 45 mins"}

};

        }
        // default OnPost method to create new record
        public void OnPost()
        {
           
            
        }

    }
}

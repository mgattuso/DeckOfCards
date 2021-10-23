using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeckOfCards.Models;

namespace DeckOfCards.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<Card>> Get()
        {
            var deck = Deck.RandomDeck();
            //var deck = Deck.OrderedDeck();

            return deck.ToList();
        }

    }
}

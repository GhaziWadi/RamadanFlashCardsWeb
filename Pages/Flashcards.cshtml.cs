// Pages/Flashcards.cshtml.cs
using Microsoft.AspNetCore.Mvc.RazorPages;
using RamadanFlashcardsWeb.Models;
using RamadanFlashcardsWeb.Services;
using System.Collections.Generic;

namespace RamadanFlashcardsWeb.Pages
{
    public class FlashcardsModel : PageModel
    {
        private readonly FlashcardService _flashcardService;

        public FlashcardsModel(FlashcardService flashcardService)
        {
            _flashcardService = flashcardService;
        }

        public List<Flashcard> Flashcards { get; set; }

        public void OnGet()
        {
            Flashcards = _flashcardService.GetFlashcards();
        }
    }
}

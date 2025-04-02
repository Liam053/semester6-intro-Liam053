﻿using Microsoft.AspNetCore.Mvc;
using Semester6LiamKleinhalle.Helpers;

namespace Semester6LiamKleinhalle.Controllers
{
    public class S6ASPSEC01Controller : Controller
    {
        // Actie voor het weergeven van de encryptiepagina
        public IActionResult S6ASPEC01()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Encrypt(string input, int key)
        {
            string encryptedText = EncryptionFunctions.Encrypt(input, key);
            ViewBag.EncryptedText = encryptedText;
            return View("S6ASPEC01");
        }

        // Actie voor het decrypten van de tekst (optioneel voor de decryptie functionaliteit)
        [HttpPost]
        public IActionResult Decrypt(string input, int key)
        {
            // Decrypt de tekst
            string decryptedText = EncryptionFunctions.Decrypt(input, key);
            // Stuur de gedecryptte tekst naar de view via ViewBag
            ViewBag.DecryptedText = decryptedText;
            // Laad de indexpagina met de gedecryptte tekst
            return View("S6ASPEC01");
        }
    }
}

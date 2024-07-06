﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Management.Application.Services
{
    public class CommonService : ICommonService
    {
        public string GenerateRandomCode(int number)
        {

            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@#!";

            Random random = new Random();

            var blindCharacters = Enumerable.Range(0, number).Select(c => characters[random.Next(0, characters.Length)]);

            return new string(blindCharacters.ToArray());
        }

    }
}

﻿/* public string GenerateISBN()
       {
           Random random = new Random();
           string isbn = "978";
           for (int i = 0; i < 9; i++)
           {
               isbn += random.Next(0, 10);
           }

           // Calculate the check digit
           int sum = 0;
           for (int i = 0; i < 12; i++)
           {
               int digit = int.Parse(isbn[i].ToString());
               sum += (i % 2 == 0) ? digit : digit * 3;
           }
           int checkDigit = (10 - sum % 10) % 10;

           isbn += checkDigit.ToString();

           return isbn;
       }*/

using System;
using System.Collections.Generic;

namespace CustomerIdGenerator
{
    public class Generator
    {
        List<string> context = new List<string>() { "DX645789", "AC125489", "KL985632" }; //replace this list with a Database!
        private int Length { get; set; }

        public Generator(List<string> context)
        {
            this.context = context;
        }
        public Generator(int length, List<string> context)
        {
            this.context = context;
            this.Length = length;
        }
        private string GetLetters()
        {
            Random rnd = new Random();
            string customerId = "";
            int ascii_index = 0;

            for (int i = 0; i < 2; i++)
            {
                ascii_index = rnd.Next(65, 91);
                char upperCaseLetter = Convert.ToChar(ascii_index);
                customerId += upperCaseLetter;
            }
            return customerId;
        }
        private string GetNumbers()
        {
            Random rnd = new Random();
            string numbers = "";
            if (Length == 0)
            {
                int[] num = new int[6];
                for (int i = 0; i < num.Length; i++)
                {
                    num[i] = rnd.Next(0, 10);
                    numbers += num[i].ToString();
                }
            }
            else
            {
                int[] num = new int[Length];
                for (int i = 0; i < num.Length; i++)
                {
                    num[i] = rnd.Next(0, 10);
                    numbers += num[i].ToString();
                }
            }
            return numbers;
        }
        private string CreateCUID()
        {
            string customerId = "";
            string letters = GetLetters();
            string numbers = GetNumbers();
            customerId = letters + numbers;
            if (CheckCUID(customerId) == true)
            {
                CreateCUID();
            }
            return customerId;
        }
        private bool CheckCUID(string id)
        {
            bool isTaken = false;
            string customerId = id;
            var cuidList = context;
            foreach (var item in cuidList)
            {
                if (item == customerId)
                {
                    isTaken = true;
                }
                else
                {
                    isTaken = false;
                }
            }
            return isTaken;
        }
        public string NewCuid()
        {
            return CreateCUID();
        }
    }
}

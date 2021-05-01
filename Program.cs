        public void RandomStrings(string[] words)
        {
            Random rnd = new Random();
            string word = "";
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    word += (char)rnd.Next(97, 123);
                }
                words[i] = word;
                word = "";
            }
        }

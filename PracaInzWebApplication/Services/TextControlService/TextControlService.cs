using Microsoft.EntityFrameworkCore;
using PracaInzWebApplication.Data;
using PracaInzWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Services.TextControlService
{
    public class TextControlService : ITextControlService
    {
        private readonly AppDbContext _context;
        public TextControlService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<string> CensorText(string text)
        {
            try
            {
                // var punctuation = text.Where(Char.IsPunctuation).Distinct().ToArray();
                var words = text.Split(new [] {' ', '\n', '\r', '\t' });
                int i = 0;
                foreach (var word in words)
                {
                    var wordsTmp = word.Split(new char[] { ' ', '.', ',', '?', '!', '/' });
                    foreach (var wordTmp in wordsTmp)
                    {
                        var result = await _context.CensoredWords.FirstOrDefaultAsync(x => x.Word == wordTmp.ToLower());
                        if (result != null)
                            words[i] = CensorWord(word);
                    }
                    i++;                
                }
                var returnText = string.Join(' ', words);
                return returnText;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private string CensorWord(string word)
        {
            var wordArray = word.ToCharArray();
            for (int i = 0; i < wordArray.Length; i++)
            {
                wordArray[i] = '*';
            }

            return new string(wordArray);
        }


        public async Task<int> CategoryHint(string text)
        {
            try
            {
                var categories = await _context.Categories.ToListAsync();
                Dictionary<int, int> categoriesDictionary = new Dictionary<int, int>();
                foreach(var category in categories)
                {
                    categoriesDictionary.Add(category.CategoryId, 0);
                }
                var words = text.Split(new[] { ' ', '\n', '\r', '\t', '.', ',', '?', '!', '/' });
                bool isFound=false;
                foreach(var word in words)
                {
                    var tag = await _context.Tags.FirstOrDefaultAsync(x => x.Name == word.ToLower());
                    if(tag!=null)
                    {
                        isFound = true;
                        var categoriesFind = await _context.TagCategories.Where(x => x.TagId == tag.TagId).ToListAsync();
                        foreach(var categroryFind in categoriesFind)
                        {
                            categoriesDictionary[categroryFind.CategoryId]++;
                        }
                    }
                }
                int keyOfMaxValue=100; // 100 means no found in tags
                if (isFound == true)
                {
                     keyOfMaxValue = categoriesDictionary.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
                }
     
                return  keyOfMaxValue;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }

}

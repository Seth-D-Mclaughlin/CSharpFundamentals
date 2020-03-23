using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        //Methods
        //Create
        public bool AddContentToDirectory(StreamingContent content) //Add method
        {
            int startingCount = _contentDirectory.Count; //Get starting count of objects
            _contentDirectory.Add(content); //Adding new content
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false; //Checking to ensure it was added
            return wasAdded; //return if it was true or false
        }

        //Read
        public List<StreamingContent> GetContent() //Read
        {
            return _contentDirectory;
        }

        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }
    }
}

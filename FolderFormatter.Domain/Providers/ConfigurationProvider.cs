using FolderFormatter.Domain.Interfaces;
using FolderFormatter.Domain.Models;
using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FolderFormatter.Domain.Providers
{
    public class ConfigurationProvider : IConfiguration
    {
        public IList<string> GetAllConfigurationsNames()
        {
            var filePath = "D:\\Development\\FolderFormatter\\FolderFormatter";
            filePath = filePath+ "\\Configurations\\ConfigurationList.json";

            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                var configurationList = JsonConvert.DeserializeObject<ConfigurationModel []>(json);
                return configurationList.Select(cf => cf.UserName).ToList();
            }
        }
    }
}

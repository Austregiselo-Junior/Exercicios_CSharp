using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_InversaodeDependencia
{
    /// <summary>
    /// Como a classe Logger recebe as interfaces no construtor, quando a logger é instanciada conseguimos ter acesso aos métodos 
    /// implementados na base de dados.
    /// </summary>
    internal class Logger
    {
        private readonly IDataService _dataService;
        private readonly IFileService _fileService;

        public Logger(IDataService dataService)
        {
            _dataService = dataService;
        }

        public Logger(IFileService fileService) 
        {
            _fileService = fileService;
        }

        public void Log(string message) 
        {
            _dataService.Save(message);
        }

        public void FileLog(string message) 
        {
            _fileService.SaveFile(message);
        }
    }
}

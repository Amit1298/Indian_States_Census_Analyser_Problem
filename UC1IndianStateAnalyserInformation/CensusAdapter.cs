using System;
using System.Collections.Generic;
using System.Text;

namespace UC1IndianStateAnalyserInformation
{
    public abstract class CensusAdapter
    {
        protected string[] GetCensusData(string csvFilePath, string dataHeaders)
        {
            string censusData;
            if (!csvFilePath.Exists(csvFilePath))
            {
                throw new CensusAnalyserException("File Not Found", CensusAnalyserException.ExceptionType.File_NOT_FOUND);
            }
            if(csvFilePath.GetExtension(csvFilePath) != ".csv")
            {
                throw new CensusAnalyserException("Invalid File Type", CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE);
            }
            censusData = File.ReadAllLines(csvFilePath);
            if (censusData[0] != dataHeaders)
            {
                throw new CensusAnalyserException("Incorrect header in data", CensusAnalyserException.ExceptionType.INCORRECT_HEADER);
            }
            return censusData;
        }
    }
}

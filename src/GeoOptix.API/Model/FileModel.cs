/* 
   Copyright 2017 Sitka Technology Group LLC

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using System;
using Newtonsoft.Json;

namespace GeoOptix.API.Model
{
    public class FileModel : FileSummaryModel
    {
        [JsonProperty("size")]
        public long Size { get; private set; }

        [JsonProperty("dateUploaded")]
        public DateTime DateUploaded { get; private set; }

        [JsonProperty("hash")]
        public string Hash { get; private set; }
        

        [Obsolete] public FileModel() { }


        public FileModel(string name, string description, string folderUrl, string fileUrl, long size, DateTime dateUploaded, string hash)
            : base(name, description, folderUrl, fileUrl)
        {
            Size = size;
            DateUploaded = dateUploaded;
            Hash = hash;
        }
    }
}
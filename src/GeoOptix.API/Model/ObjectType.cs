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

namespace GeoOptix.API.Model
{
    public enum ObjectType
    {
        Program = 1,
        Watershed = 2,
        Site = 3,
        Visit = 4,
        File = 5,
        Folder = 6,
        FieldFolder = 7,
        MeasurementType = 8,
        Measurement = 9,
        WorkEffort = 10,
        Protocol = 11
    }
}
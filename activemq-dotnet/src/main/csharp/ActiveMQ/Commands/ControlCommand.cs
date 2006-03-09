/*
* Copyright 2006 The Apache Software Foundation or its licensors, as
* applicable.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*     http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

//
//  NOTE!: This file is autogenerated - do not modify!
//         if you need to make a change, please see the Groovy scripts in the
//         activemq-core module
//

using System;
using System.Collections;

using ActiveMQ.OpenWire;
using ActiveMQ.Commands;

namespace ActiveMQ.Commands
{
	/// <summary>
    ///  The ActiveMQ ControlCommand Command
	/// </summary>
    public class ControlCommand : BaseCommand
    {
        public const byte ID_ControlCommand = 14;
    			
        string command;

		public override string ToString() {
            return GetType().Name + "["
                + " Command=" + Command
                + " ]";

		}
	


        public override byte GetDataStructureType() {
            return ID_ControlCommand;
        }


        // Properties

        public string Command
        {
            get { return command; }
            set { this.command = value; }            
        }

    }
}

// This namespaces are the ones you have access.
// The available namespaces will be expanded over time.
// Namespaces can be requested through the contact formular
using apsiba.codeRunner.sdk;
using System.Collections.Generic;
using System.Linq;

// The code you supply, will be the body of the demonstrated method below.


class TestRunner : IRunner
{
	public void Run(
		IDataManager customerData,
		IDataManager userData,
		IDictionary<int, IDataManager> otherUserData,
		IDictionary<string, int> userMapping)
	{
		//Here lies your Code. 
		//Available namespaces:
		//-  System.Collections.Generic;
		//-  System.Linq;
		//-  apsiba.codeRunner.sdk;
	}
}

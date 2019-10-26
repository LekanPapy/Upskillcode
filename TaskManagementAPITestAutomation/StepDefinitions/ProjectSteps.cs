using System;
using TechTalk.SpecFlow;
using TaskManagementAPITestAutomation.Hooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow.Assist;
using TaskManagementAPITestAutomation.Model;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace TaskManagementAPITestAutomation.StepDefinitions
{
    [Binding]
    public class ProjectSteps
    {
        DatabaseHelper databaseHelper;
        Context context;

        public ProjectSteps(DatabaseHelper _databaseHelper, Context _context)
        {
            databaseHelper = _databaseHelper;
            context = _context;
        }

        [Given(@"that TaskManagementSystem web services with GET endpoint (.*) is running")]
        public void GivenThatTaskManagementSystemWebServicesWithGETEndpointProjectsIsRunning(string resource)
        {
            databaseHelper.ClearProjectsTable();
            databaseHelper.PopulateProjectsTableWithMultipleRecords();
            context.GetHttpMethod(resource);            
        }
        
        [Then(@"the status code for GET endpoint is equal to (.*)")]
        public void ThenTheStatusCodeForGETEndpointIsEqualToOK(string expectedResult)
        {            
            Assert.AreEqual(expectedResult, context.statusCode, $"{expectedResult} result is not equal to an actual result of {context.statusCode}");
        }
        
        [Then(@"the following records should be retrieved from Projects table")]
        public void ThenTheFollowingRecordsShouldBeRetrievedFromProjectsTable(Table table)
        {
            var expectedResult = table.CreateSet<ProjectModel>(); //Change table records to a list which is a collection
            //string actualResponseContent = context.content;       //This will be in Json format which consist of many things beyond our need
            var actualResult = JsonConvert.DeserializeObject<List<ProjectModel>>(context.content); //it will take out all data under Name attribute/column

            Assert.IsTrue(CompareTwoCollections(expectedResult,actualResult));
        }

        public bool CompareTwoCollections(object firstCollection, object secondCollection)
        {
            var firstObject = JsonConvert.SerializeObject(firstCollection);
            var secondObject = JsonConvert.SerializeObject(secondCollection);
            return firstObject == secondObject;
        }

        [Given(@"that TaskManagementSystem web services with POST endpoint (.*) is running")]
        public void GivenThatTaskManagementSystemWebServicesWithPOSTEndpointProjectsIsRunning(string resource)
        {
            databaseHelper.ClearProjectsTable();
            Dictionary<string, string> dataToPost = new Dictionary<string, string>();
            dataToPost.Add("Name", "API Test Automation");
            context.PostHttpMethod(resource, dataToPost);
        }

        [Then(@"the status code for POST endpoint is equal to (.*)")]
        public void ThenTheStatusCodeForPOSTEndpointIsEqualToCreated(string expectedStatusCode)
        {
            Assert.IsTrue(expectedStatusCode.Equals(context.statusCode));
        }

        [Then(@"the response description for POST endpoint is equal to (.*)")]
        public void ThenTheResponseDescriptionForPOSTEndpointIsEqualToCreated(string expectedResponseDescription)
        {
            Assert.AreEqual(expectedResponseDescription, context.responseDescription);
        }

        [Given(@"that TaskManagementSystem web services with PUT endpoint (.*) is running")]
        public void GivenThatTaskManagementSystemWebServicesWithPUTEndpointProjectsIsRunning(string resource)
        {
            databaseHelper.ClearProjectsTable();
            databaseHelper.PopulateProjectsTableWithRecord();  //populate the table with 'Performance Testing' data
            int id = databaseHelper.SelectAProjectRecord();

            Dictionary<string, string> dataToPut = new Dictionary<string, string>();
            dataToPut.Add("Id", id.ToString());
            dataToPut.Add("Name", "API Test Automation");

            string newResource = resource + "/" + id;

            context.PutHttpMethod(newResource, dataToPut);
        }

        [Then(@"the status code for PUT endpoint is equal to (.*)")]
        public void ThenTheStatusCodeForPUTEndpointIsEqualToNoContent(string expectedStatusCode)
        {
            Assert.IsTrue(expectedStatusCode.Equals(context.statusCode));
        }

        [Then(@"the response description for PUT endpoint is equal to (.*)")]
        public void ThenTheResponseDescriptionForPUTEndpointIsEqualToNoContent(string expectedResponseDescription)
        {
            Assert.IsTrue(expectedResponseDescription.Equals(context.responseDescription));
        }

        [Given(@"that TaskManagementSystem web services with DELETE endpoint (.*) is running")]
        public void GivenThatTaskManagementSystemWebServicesWithDELETEEndpointProjectsIsRunning(string resource)
        {
            databaseHelper.ClearProjectsTable();
            databaseHelper.PopulateProjectsTableWithRecord();  //populate the table with 'Performance Testing' data
            int id = databaseHelper.SelectAProjectRecord();
            string newResource = resource + "/" + id;
            context.DeleteHttpMethod(newResource);
        }

        [Then(@"the status code for DELETE endpoint is equal to (.*)")]
        public void ThenTheStatusCodeForDELETEEndpointIsEqualToOK(string expectedStatusCode)
        {
            Assert.IsTrue(expectedStatusCode.Equals(context.statusCode));
        }

        [Then(@"the response description for DELETE endpoint is equal to (.*)")]
        public void ThenTheResponseDescriptionForDELETEEndpointIsEqualToOK(string expectedDescriptionCode)
        {
            Assert.IsTrue(expectedDescriptionCode.Equals(context.responseDescription));
        }

    }
}

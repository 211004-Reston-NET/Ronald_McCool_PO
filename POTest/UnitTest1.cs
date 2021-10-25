using System;
using Xunit;
using Models;

namespace POTest
{
    public class UnitTest1
    {
        /// <summary>
        /// will test store name property will set with valid data
        /// valid data - no numbers
        /// </summary>
        [Fact]
        public void StoreNameShouldSetValidData()
        {
            //arrange
            Store _store =new Store();
            string name = "Johns";
            //act
            _store.Name=name;
            //asseret
            Assert.NotNull(_store.Name);
            Assert.Equal(_store.Name, name);
            
            

        }
        [Theory]
        [InlineData("Houston123")]
        [InlineData("123Houston")]
        [InlineData("Hou123ston")]
        public void StoreShouldFailifSetWithInvalidData(string _name){
            //arrange
            
            Store _store =new Store();
            
            //act and assert
            Assert.Throws<Exception>(()=>_store.Name=_name);

        }
    }
}

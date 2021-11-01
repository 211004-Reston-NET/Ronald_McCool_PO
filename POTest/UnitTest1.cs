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
        [InlineData("123Houston456")]
        public void StoreShouldFailifSetWithInvalidData(string _name){
            //arrange
            
            Store _store =new Store();
            
            //act and assert
            Assert.Throws<Exception>(()=>_store.Name=_name);

        }
        [Fact]
        public void CustNameShouldSetValidData()
        {
            //arrange
            Customer _cust=new Customer();
            string name = "Ron";
            //act
            _cust.Name=name;
            //asseret
            Assert.NotNull(_cust.Name);
            Assert.Equal(_cust.Name, name);
            
            

        }
         [Theory]
        [InlineData("Ron123")]
        [InlineData("123Ron")]
        [InlineData("R123on")]
        [InlineData("123Ron456")]
        public void CustShouldFailifSetWithInvalidData(string _name){
            //arrange
            
            Customer _cust =new Customer();
            
            //act and assert
            Assert.Throws<Exception>(()=>_cust.Name=_name);

        }
    }
}

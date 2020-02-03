using System;
using System.Collections.Generic;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        int count = 0;

        public delegate string WriteLogDelegate(string logMessage);

        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = DelegateReturnMethod;

            //  log = new WriteLogDelegate(DelegateReturnMethod);
            log += DelegateReturnMethod;
            log += IncrementCount;

            var result = log("Hello");

            Assert.Equal(3, count);
        }

        string DelegateReturnMethod(string message)
        {
            count++;
            return message;
        }

        string IncrementCount(string message)
        {
            count++;
            return message.ToLower();
        }


        [Fact]
        public void DoNotAllowAGradeBelowZeroOrGreaterThanOneHundred()
        {
            var book = new InMemoryBook("Book1");
            Assert.Throws<ArgumentException>(
            () => book.AddGrade(105));
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Nick";

            string uppername = MakeUpperCase(name);

            Assert.Equal("Nick", name);
            Assert.Equal("NICK", uppername);
        }

        private string MakeUpperCase(string parameter)
        {
            return parameter.ToUpper();
            
        }

        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            //arrange
            var book1 = GetBook("Book 1");
            //act
            GetBookSetName(ref book1, "New Name");
            //assert
            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(ref InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            // arrange
            var book1 = GetBook("Book 1");
            //act
            GetBookSetName(book1, "New Name");
            //assert
            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }


        [Fact]
        public void CanSetNameFromReference()
        {
            // arrange
            var book1 = GetBook("Book 1");
            //act
            SetName(book1, "New Name");
            //assert
            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(InMemoryBook book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            // arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");
            //act

            //assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVariablesCanReferenceTheSameObject()
        {
            // arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;
            //act

            //assert
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }
    }
}

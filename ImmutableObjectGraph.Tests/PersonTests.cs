﻿namespace ImmutableObjectGraph.Tests {
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Reflection;
	using System.Text;
	using System.Threading.Tasks;

	using Xunit;

	public class PersonTests {
		/// <summary>
		/// Immutable types should not have public constructors to avoid creating duplicate instances.
		/// </summary>
		[Fact]
		public void NoPublicConstructors() {
			Assert.Equal(0, typeof(Person).GetConstructors(BindingFlags.Public | BindingFlags.Instance).Length);
		}

		[Fact]
		public void DefaultInstance() {
			var defaultPerson = Person.Create();
			Assert.NotNull(defaultPerson);
			Assert.Equal(0, defaultPerson.Age);
			Assert.Equal(null, defaultPerson.Name);
		}

		[Fact]
		public void CreateWithArguments() {
			var billyAge10 = Person.Create(name: "billy", age: 10);
			Assert.Equal("billy", billyAge10.Name);
			Assert.Equal(10, billyAge10.Age);
		}

		[Fact]
		public void SetScalarReferenceTypeProperty() {
			var original = Person.Create();
			var modified = original.WithName("bill");
			Assert.Equal("bill", modified.Name);
			Assert.Null(original.Name);
		}

		[Fact]
		public void SetScalarValueTypeProperty() {
			var original = Person.Create();
			var modified = original.WithAge(8);
			Assert.Equal(8, modified.Age);
			Assert.Equal(0, original.Age);
		}

		[Fact]
		public void SetScalarReferenceTypePropertyToSameValueReturnsSameInstance() {
			var expected = Person.Create().WithName("bill");
			var actual = expected.WithName(expected.Name);
			Assert.Same(expected, actual);
		}

		[Fact]
		public void SetScalarValueTypePropertyToSameValueReturnsSameInstance() {
			var expected = Person.Create().WithAge(8);
			var actual = expected.WithAge(expected.Age);
			Assert.Same(expected, actual);
		}

		[Fact]
		public void With() {
			// Initialize
			var billAge10 = Person.Create().With(name: "bill", age: 10);
			Assert.Equal("bill", billAge10.Name);
			Assert.Equal(10, billAge10.Age);

			// Full modification
			var jillAge9 = billAge10.With(name: "jill", age: 9);
			Assert.Equal("jill", jillAge9.Name);
			Assert.Equal(9, jillAge9.Age);

			// Partial modification
			var billAge12 = billAge10.With(age: 12);
			Assert.Equal("bill", billAge12.Name);
			Assert.Equal(12, billAge12.Age);

			var billyAge10 = billAge10.With(name: "billy");
			Assert.Equal("billy", billyAge10.Name);
			Assert.Equal(10, billyAge10.Age);
		}
	}
}

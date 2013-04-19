﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ImmutableTree Version: 0.0.0.1
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace ImmutableObjectGraph {
	using System.Diagnostics;

	
	public partial class Person {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly Person DefaultInstance = new Person();
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.String name;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Int32 age;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Watch watch;
	
		/// <summary>Initializes a new instance of the Person class.</summary>
		private Person()
		{
		}
	
		/// <summary>Initializes a new instance of the Person class.</summary>
		private Person(System.String name, System.Int32 age, Watch watch)
		{
			this.name = name;
			this.age = age;
			this.watch = watch;
			this.Validate();
		}
	
		public static Person Create(
			ImmutableObjectGraph.Optional<System.String> name = default(ImmutableObjectGraph.Optional<System.String>), 
			ImmutableObjectGraph.Optional<System.Int32> age = default(ImmutableObjectGraph.Optional<System.Int32>), 
			ImmutableObjectGraph.Optional<Watch> watch = default(ImmutableObjectGraph.Optional<Watch>)) {
			return DefaultInstance.With(
				name, 
				age, 
				watch);
		}
	
		public System.String Name {
			get { return this.name; }
		}
	
		public Person WithName(System.String value) {
			if (value == this.Name) {
				return this;
			}
	
			return new Person(value, this.Age, this.Watch);
		}
	
		public System.Int32 Age {
			get { return this.age; }
		}
	
		public Person WithAge(System.Int32 value) {
			if (value == this.Age) {
				return this;
			}
	
			return new Person(this.Name, value, this.Watch);
		}
	
		public Watch Watch {
			get { return this.watch; }
		}
	
		public Person WithWatch(Watch value) {
			if (value == this.Watch) {
				return this;
			}
	
			return new Person(this.Name, this.Age, value);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public Person With(
			ImmutableObjectGraph.Optional<System.String> name = default(ImmutableObjectGraph.Optional<System.String>), 
			ImmutableObjectGraph.Optional<System.Int32> age = default(ImmutableObjectGraph.Optional<System.Int32>), 
			ImmutableObjectGraph.Optional<Watch> watch = default(ImmutableObjectGraph.Optional<Watch>)) {
			if (
				(name.IsDefined && name.Value != this.Name) || 
				(age.IsDefined && age.Value != this.Age) || 
				(watch.IsDefined && watch.Value != this.Watch)) {
				return new Person(
					name.IsDefined ? name.Value : this.Name,
					age.IsDefined ? age.Value : this.Age,
					watch.IsDefined ? watch.Value : this.Watch);
			} else {
				return this;
			}
		}
	
		public Builder ToBuilder() {
			return new Builder(this);
		}
	
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		public partial class Builder {
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private Person immutable;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private System.String name;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private System.Int32 age;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private Optional<Watch.Builder> watch;
	
			internal Builder(Person immutable) {
				this.immutable = immutable;
	
				this.name = immutable.Name;
				this.age = immutable.Age;
			}
	
			public System.String Name {
				get {
					return this.name;
				}
	
				set {
					this.name = value;
				}
			}
	
			public System.Int32 Age {
				get {
					return this.age;
				}
	
				set {
					this.age = value;
				}
			}
	
			public Watch.Builder Watch {
				get {
					if (!this.watch.IsDefined) {
						this.watch = this.immutable.watch.ToBuilder();
					}

					return this.watch.Value;
				}
	
				set {
					this.watch = value;
				}
			}

			public Person ToImmutable() {
				var watch = this.watch.IsDefined ? (this.watch.Value != null ? this.watch.Value.ToImmutable() : null) : this.immutable.watch;
				return this.immutable = this.immutable.With(
					ImmutableObjectGraph.Optional.For(this.name),
					ImmutableObjectGraph.Optional.For(this.age),
					ImmutableObjectGraph.Optional.For(watch));
			}
		}
	}
	
	public partial class Watch {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly Watch DefaultInstance = new Watch();
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.String color;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Int32 size;
	
		/// <summary>Initializes a new instance of the Watch class.</summary>
		private Watch()
		{
		}
	
		/// <summary>Initializes a new instance of the Watch class.</summary>
		private Watch(System.String color, System.Int32 size)
		{
			this.color = color;
			this.size = size;
			this.Validate();
		}
	
		public static Watch Create(
			ImmutableObjectGraph.Optional<System.String> color = default(ImmutableObjectGraph.Optional<System.String>), 
			ImmutableObjectGraph.Optional<System.Int32> size = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			return DefaultInstance.With(
				color, 
				size);
		}
	
		public System.String Color {
			get { return this.color; }
		}
	
		public Watch WithColor(System.String value) {
			if (value == this.Color) {
				return this;
			}
	
			return new Watch(value, this.Size);
		}
	
		public System.Int32 Size {
			get { return this.size; }
		}
	
		public Watch WithSize(System.Int32 value) {
			if (value == this.Size) {
				return this;
			}
	
			return new Watch(this.Color, value);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public Watch With(
			ImmutableObjectGraph.Optional<System.String> color = default(ImmutableObjectGraph.Optional<System.String>), 
			ImmutableObjectGraph.Optional<System.Int32> size = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			if (
				(color.IsDefined && color.Value != this.Color) || 
				(size.IsDefined && size.Value != this.Size)) {
				return new Watch(
					color.IsDefined ? color.Value : this.Color,
					size.IsDefined ? size.Value : this.Size);
			} else {
				return this;
			}
		}
	
		public Builder ToBuilder() {
			return new Builder(this);
		}
	
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		public partial class Builder {
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private Watch immutable;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private System.String color;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private System.Int32 size;
	
			internal Builder(Watch immutable) {
				this.immutable = immutable;
	
				this.color = immutable.Color;
				this.size = immutable.Size;
			}
	
			public System.String Color {
				get {
					return this.color;
				}
	
				set {
					this.color = value;
				}
			}
	
			public System.Int32 Size {
				get {
					return this.size;
				}
	
				set {
					this.size = value;
				}
			}
	
			public Watch ToImmutable() {
				return this.immutable = this.immutable.With(
					ImmutableObjectGraph.Optional.For(this.color),
					ImmutableObjectGraph.Optional.For(this.size));
			}
		}
	}
}


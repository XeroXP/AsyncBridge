// https://github.com/dotnet/coreclr/blob/v2.1.0/src/mscorlib/shared/System/Runtime/CompilerServices/StateMachineAttribute.cs
// Original work under MIT license, Copyright (c) .NET Foundation and Contributors https://github.com/dotnet/coreclr/blob/v2.1.0/LICENSE.TXT
// Docs supplemented from https://github.com/dotnet/dotnet-api-docs/blob/live/xml/System.Runtime.CompilerServices/StateMachineAttribute.xml
// Docs under Creative Commons Attribution 4.0 International Public License https://github.com/dotnet/dotnet-api-docs/blob/live/LICENSE

using System;

namespace System.Runtime.CompilerServices
{
    /// <summary>Allows you to determine whether a method is a state machine method.</summary>
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public class StateMachineAttribute : Attribute
    {
        /// <param name="stateMachineType">The type object for the underlying state machine type that was generated by the compiler to implement the state machine method.</param>
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.StateMachineAttribute" /> class.</summary>
        public StateMachineAttribute(Type stateMachineType)
        {
            StateMachineType = stateMachineType;
        }

        /// <summary>Returns the type object for the underlying state machine type that was generated by the compiler to implement the state machine method.</summary>
        /// <value>Gets the type object for the underlying state machine type that was generated by the compiler to implement the state machine method.</value>
        public Type StateMachineType { get; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kerberos.NET.Asn1.Experimental {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AsnResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AsnResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Kerberos.NET.Asn1.Experimental.AsnResources", typeof(AsnResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only single dimensional arrays are supported for the requested action..
        /// </summary>
        internal static string Arg_RankMultiDimNotSupported {
            get {
                return ResourceManager.GetString("Arg_RankMultiDimNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The destination is too small to hold the encoded value..
        /// </summary>
        internal static string Argument_EncodeDestinationTooSmall {
            get {
                return ResourceManager.GetString("Argument_EncodeDestinationTooSmall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection..
        /// </summary>
        internal static string Argument_InvalidOffLen {
            get {
                return ResourceManager.GetString("Argument_InvalidOffLen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The OID value was invalid..
        /// </summary>
        internal static string Argument_InvalidOidValue {
            get {
                return ResourceManager.GetString("Argument_InvalidOidValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value was invalid..
        /// </summary>
        internal static string Argument_InvalidValue {
            get {
                return ResourceManager.GetString("Argument_InvalidValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Index was out of range. Must be non-negative and less than the size of the collection..
        /// </summary>
        internal static string ArgumentOutOfRange_Index {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_Index", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Non-negative number required..
        /// </summary>
        internal static string ArgumentOutOfRange_NeedNonNegNum {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_NeedNonNegNum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ASN.1 Enumerated values only apply to enum types without the [Flags] attribute..
        /// </summary>
        internal static string Cryptography_Asn_EnumeratedValueRequiresNonFlagsEnum {
            get {
                return ResourceManager.GetString("Cryptography_Asn_EnumeratedValueRequiresNonFlagsEnum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Named bit list operations require an enum with the [Flags] attribute..
        /// </summary>
        internal static string Cryptography_Asn_NamedBitListRequiresFlagsEnum {
            get {
                return ResourceManager.GetString("Cryptography_Asn_NamedBitListRequiresFlagsEnum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The encoded named bit list value is larger than the value size of the &apos;{0}&apos; enum..
        /// </summary>
        internal static string Cryptography_Asn_NamedBitListValueTooBig {
            get {
                return ResourceManager.GetString("Cryptography_Asn_NamedBitListValueTooBig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tags with TagClass Universal must have the appropriate TagValue value for the data type being read or written..
        /// </summary>
        internal static string Cryptography_Asn_UniversalValueIsFixed {
            get {
                return ResourceManager.GetString("Cryptography_Asn_UniversalValueIsFixed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unused bit count must be between 0 and 7, inclusive..
        /// </summary>
        internal static string Cryptography_Asn_UnusedBitCountRange {
            get {
                return ResourceManager.GetString("Cryptography_Asn_UnusedBitCountRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encode cannot be called while a Sequence or SetOf is still open..
        /// </summary>
        internal static string Cryptography_AsnWriter_EncodeUnbalancedStack {
            get {
                return ResourceManager.GetString("Cryptography_AsnWriter_EncodeUnbalancedStack", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot pop the requested tag as it is not currently in progress..
        /// </summary>
        internal static string Cryptography_AsnWriter_PopWrongTag {
            get {
                return ResourceManager.GetString("Cryptography_AsnWriter_PopWrongTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ASN1 corrupted data..
        /// </summary>
        internal static string Cryptography_Der_Invalid_Encoding {
            get {
                return ResourceManager.GetString("Cryptography_Der_Invalid_Encoding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ASN1 corrupted data. Expected {0}; Actual: {1}.
        /// </summary>
        internal static string Cryptography_Der_Invalid_Encoding_Expected_Encoding {
            get {
                return ResourceManager.GetString("Cryptography_Der_Invalid_Encoding_Expected_Encoding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The string contains a character not in the 7 bit ASCII character set..
        /// </summary>
        internal static string Cryptography_Invalid_IA5String {
            get {
                return ResourceManager.GetString("Cryptography_Invalid_IA5String", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No OID value matches this name..
        /// </summary>
        internal static string Cryptography_Oid_InvalidName {
            get {
                return ResourceManager.GetString("Cryptography_Oid_InvalidName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The OID value is invalid..
        /// </summary>
        internal static string Cryptography_Oid_InvalidValue {
            get {
                return ResourceManager.GetString("Cryptography_Oid_InvalidValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NoLength of the data to encrypt is invalid..
        /// </summary>
        internal static string Cryptography_SSE_InvalidDataSize {
            get {
                return ResourceManager.GetString("Cryptography_SSE_InvalidDataSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The input to WriteEncodedValue must represent a single encoded value with no trailing data..
        /// </summary>
        internal static string Cryptography_WriteEncodedValue_OneValueAtATime {
            get {
                return ResourceManager.GetString("Cryptography_WriteEncodedValue_OneValueAtATime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot access a disposed object..
        /// </summary>
        internal static string ObjectDisposed_Generic {
            get {
                return ResourceManager.GetString("ObjectDisposed_Generic", resourceCulture);
            }
        }
    }
}
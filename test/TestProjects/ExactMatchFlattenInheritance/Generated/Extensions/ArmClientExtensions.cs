// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;

namespace ExactMatchFlattenInheritance
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region AzureResourceFlattenModel1
        /// <summary> Gets an object representing a AzureResourceFlattenModel1 along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AzureResourceFlattenModel1" /> object. </returns>
        public static AzureResourceFlattenModel1 GetAzureResourceFlattenModel1(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new AzureResourceFlattenModel1(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region AzureResourceFlattenModel2
        /// <summary> Gets an object representing a AzureResourceFlattenModel2 along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AzureResourceFlattenModel2" /> object. </returns>
        public static AzureResourceFlattenModel2 GetAzureResourceFlattenModel2(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new AzureResourceFlattenModel2(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region AzureResourceFlattenModel3
        /// <summary> Gets an object representing a AzureResourceFlattenModel3 along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AzureResourceFlattenModel3" /> object. </returns>
        public static AzureResourceFlattenModel3 GetAzureResourceFlattenModel3(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new AzureResourceFlattenModel3(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region AzureResourceFlattenModel4
        /// <summary> Gets an object representing a AzureResourceFlattenModel4 along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AzureResourceFlattenModel4" /> object. </returns>
        public static AzureResourceFlattenModel4 GetAzureResourceFlattenModel4(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new AzureResourceFlattenModel4(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region AzureResourceFlattenModel5
        /// <summary> Gets an object representing a AzureResourceFlattenModel5 along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AzureResourceFlattenModel5" /> object. </returns>
        public static AzureResourceFlattenModel5 GetAzureResourceFlattenModel5(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new AzureResourceFlattenModel5(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region CustomModel2
        /// <summary> Gets an object representing a CustomModel2 along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CustomModel2" /> object. </returns>
        public static CustomModel2 GetCustomModel2(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new CustomModel2(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region CustomModel3
        /// <summary> Gets an object representing a CustomModel3 along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CustomModel3" /> object. </returns>
        public static CustomModel3 GetCustomModel3(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new CustomModel3(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}

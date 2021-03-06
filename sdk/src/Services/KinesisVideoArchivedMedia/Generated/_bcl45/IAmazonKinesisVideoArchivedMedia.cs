/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the kinesis-video-archived-media-2017-09-30.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.KinesisVideoArchivedMedia.Model;

namespace Amazon.KinesisVideoArchivedMedia
{
    /// <summary>
    /// Interface for accessing KinesisVideoArchivedMedia
    ///
    /// 
    /// </summary>
    public partial interface IAmazonKinesisVideoArchivedMedia : IAmazonService, IDisposable
    {

        
        #region  GetMediaForFragmentList


        /// <summary>
        /// Gets media for a list of fragments (specified by fragment number) from the archived
        /// data in a Kinesis video stream.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is only available for the AWS SDK for Java. It is not supported in
        /// AWS SDKs for other languages.
        /// </para>
        ///  </note> 
        /// <para>
        /// The following limits apply when using the <code>GetMediaForFragmentList</code> API:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A client can call <code>GetMediaForFragmentList</code> up to five times per second
        /// per stream. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Kinesis Video Streams sends media data at a rate of up to 25 megabytes per second
        /// (or 200 megabits per second) during a <code>GetMediaForFragmentList</code> session.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMediaForFragmentList service method.</param>
        /// 
        /// <returns>The response from the GetMediaForFragmentList service method, as returned by KinesisVideoArchivedMedia.</returns>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NotAuthorizedException">
        /// Status Code: 403, The caller is not authorized to perform an operation on the given
        /// stream, or the token has expired.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ResourceNotFoundException">
        /// Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/GetMediaForFragmentList">REST API Reference for GetMediaForFragmentList Operation</seealso>
        GetMediaForFragmentListResponse GetMediaForFragmentList(GetMediaForFragmentListRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetMediaForFragmentList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMediaForFragmentList operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/GetMediaForFragmentList">REST API Reference for GetMediaForFragmentList Operation</seealso>
        Task<GetMediaForFragmentListResponse> GetMediaForFragmentListAsync(GetMediaForFragmentListRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFragments


        /// <summary>
        /// Returns a list of <a>Fragment</a> objects from the specified stream and start location
        /// within the archived data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFragments service method.</param>
        /// 
        /// <returns>The response from the ListFragments service method, as returned by KinesisVideoArchivedMedia.</returns>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NotAuthorizedException">
        /// Status Code: 403, The caller is not authorized to perform an operation on the given
        /// stream, or the token has expired.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ResourceNotFoundException">
        /// Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/ListFragments">REST API Reference for ListFragments Operation</seealso>
        ListFragmentsResponse ListFragments(ListFragmentsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListFragments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFragments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/ListFragments">REST API Reference for ListFragments Operation</seealso>
        Task<ListFragmentsResponse> ListFragmentsAsync(ListFragmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}
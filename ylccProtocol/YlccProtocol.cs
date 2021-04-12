using System;
using System.Collections.Generic;

namespace ylccProtocol
{
    public class YlccProtocol
    {
        public YlccProtocol()
        {

        }

		public GetVideoRequest BuildGetVideoRequest(string videoId)
        {
			return new GetVideoRequest
			{
				VideoId = videoId,
			};
		}

		public StartCollectionActiveLiveChatRequest BuildStartCollectionActiveLiveChatRequest(string videoId)
        {
			return new StartCollectionActiveLiveChatRequest
			{
				VideoId = videoId,
			};
		}

		public PollActiveLiveChatRequest BuildPollActiveLiveChatRequest(string videoId)
		{
			return new PollActiveLiveChatRequest
			{
				VideoId = videoId,
			};
		}

		public GetCachedActiveLiveChatRequest BuildGetCachedActiveLiveChatRequest(string videoId, long offset, long count)
		{
			return new GetCachedActiveLiveChatRequest
			{
				VideoId = videoId,
				Offset = offset,
				Count = count,
			};
		}

		public StartCollectionArchiveLiveChatRequest BuildStartCollectionArchiveLiveChatRequest(string videoId, bool replace)
		{
			return new StartCollectionArchiveLiveChatRequest
			{
				VideoId = videoId,
				Replace = replace,
			};
		}

		public GetArchiveLiveChatRequest BuildGetArchiveLiveChatRequest(string videoId, long offset, long count)
		{
			return new GetArchiveLiveChatRequest
			{
				VideoId = videoId,
				Offset = offset,
				Count = count,
			};
		}

		public StartCollectionWordCloudMessagesRequest BuildStartCollectionWordCloudMessagesRequest(string videoId)
		{
			return new StartCollectionWordCloudMessagesRequest
			{
				VideoId = videoId,
			};
		}
		public GetWordCloudRequest BuildGetWordCloudRequest(string videoId, Target target, int width, int height, int fontMaxSize, int fontMinSize, ICollection<Color> colors, Color backgroudColor)
		{
			GetWordCloudRequest request = new GetWordCloudRequest
			{
				VideoId = videoId,
				Target = target,
				Width = width,
				Height = height,
				FontMaxSize = fontMaxSize,
				FontMinSize = fontMinSize,
				BackgroundColor = backgroudColor,
			};
			foreach (Color color in colors) {
				request.Colors.Add(color);
			}
			return request;
		}
	}
}

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

		public Color BuildCorlor(string color)
        {
			System.Drawing.Color dColor = System.Drawing.ColorTranslator.FromHtml(color);
			return new Color() { R = dColor.R, G = dColor.G, B = dColor.B, A = dColor.A };
		}

		public Color BuildCorlor(UInt32 r, UInt32 g, UInt32 b, UInt32 a)
		{
			return new Color() { R = r, G = g, B = b, A = a };
		}

		public GetWordCloudRequest BuildGetWordCloudRequest(string videoId, Target target, int messageLimit, int width, int height, int fontMaxSize, int fontMinSize, ICollection<Color> colors, Color backgroudColor)
		{
			GetWordCloudRequest request = new GetWordCloudRequest
			{
				VideoId = videoId,
				Target = target,
				MessageLimit = messageLimit,
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

		public VoteChoice BuildVoteCoice(string label, string choice)
        {
			return new VoteChoice() { Label = label, Choice = choice };
		}

		public OpenVoteRequest BuildOpenVoteRequest(string videoId, Target target, int duration,  ICollection<VoteChoice> choices)
		{
			OpenVoteRequest request = new OpenVoteRequest
			{
				VideoId = videoId,
				Target = target,
				Duration = duration,
			};
			foreach (VoteChoice choice in choices)
			{
				request.Choices.Add(choice);
			}
			return request;
		}

		public UpdateVoteDurationRequest BuildUpdateVoteDurationRequest(string voteId, int duration)
		{
			UpdateVoteDurationRequest request = new UpdateVoteDurationRequest
			{
				VoteId = voteId,
				Duration = duration,
			};
			return request;
		}

		public GetVoteResultRequest BuildGetVoteResultRequest(string voteId)
		{
			GetVoteResultRequest request = new GetVoteResultRequest
			{
				VoteId = voteId,
			};
			return request;
		}

		public CloseVoteRequest BuildCloseVoteRequest(string voteId)
		{
			CloseVoteRequest request = new CloseVoteRequest
			{
				VoteId = voteId,
			};
			return request;
		}

		public GroupingChoice BuildGroupingCoice(string label, string choice)
		{
			return new GroupingChoice() { Label = label, Choice = choice };
		}

		public StartGroupingActiveLiveChatRequest BuildStartGroupingActiveLiveChatRequest(string videoId, Target target, ICollection<GroupingChoice> choices)
        {
			StartGroupingActiveLiveChatRequest request = new StartGroupingActiveLiveChatRequest
			{
				VideoId = videoId,
				Target = target,				
			};
			foreach (GroupingChoice choice in choices)
			{
				request.Choices.Add(choice);
			}
			return request;
		}

		public PollGroupingActiveLiveChatRequest BuildPollGroupingActiveLiveChatRequest(string groupingId)
		{
			return new PollGroupingActiveLiveChatRequest
			{
				GroupingId = groupingId,
			};
		}


	}
}

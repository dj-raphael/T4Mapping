

using System.Linq;

namespace ConsoleApplicationParceAttribute.T4_Folder  
{ 
	 public static class MappingExtension
	 { 

//DataObjects.NewsToTags
//DataObjects.Tag	
		public static DataTransferObject.NewsDto MapToDto (this DataObjects.News item)
		{  
			if (item == null) return null;
			
			return new DataTransferObject.NewsDto 
			{
					NewsId = item.NewsId, 
					Title = item.Title, 
					Anounce = item.Anounce, 
					Text = item.Text, 
					Status = item.Status.ToString(), 
					Category = item.Category.MapToDto(), 
					Created = item.Created, 
					Author = item.Author.Login, 
					Tags = item.NewsToTags.Select(p => p.Tag.Name), 
			};
		}

		public static DataObjects.News MapFromDto (this DataTransferObject.NewsDto itemDto)
		{  
			if (itemDto == null) return null;
			
			return new DataObjects.News 
			{
					NewsId = itemDto.NewsId,
					Title = itemDto.Title,
					Anounce = itemDto.Anounce,
					Text = itemDto.Text,
					Status = (DataObjects.Attributes.StatusEnum) System.Enum.Parse(typeof(DataObjects.Attributes.StatusEnum), itemDto.Status),
					Category = itemDto.Category.MapFromDto(),
					Created = itemDto.Created,
			};
		}
	
		public static DataTransferObject.CategoryDto MapToDto (this DataObjects.NewsCategory item)
		{  
			if (item == null) return null;
			
			return new DataTransferObject.CategoryDto 
			{
					NewsCategoryId = item.NewsCategoryId, 
					Name = item.Name, 
					ParentCategory = item.ParentCategory.MapToDto(), 
					ChildCategories = item.ChildCategories.Select(x => x.MapToDto()), 
			};
		}

		public static DataObjects.NewsCategory MapFromDto (this DataTransferObject.CategoryDto itemDto)
		{  
			if (itemDto == null) return null;
			
			return new DataObjects.NewsCategory 
			{
					NewsCategoryId = itemDto.NewsCategoryId,
					Name = itemDto.Name,
					ParentCategory = itemDto.ParentCategory.MapFromDto(),
					ChildCategories = itemDto.ChildCategories.Select(x => x.MapFromDto()),
			};
		}
	
		public static DataTransferObject.UserDto MapToDto (this DataObjects.User item)
		{  
			if (item == null) return null;
			
			return new DataTransferObject.UserDto 
			{
					UserId = item.UserId, 
					Username = item.Login, 
					Created = item.Created, 
					Email = item.Email, 
			};
		}

		public static DataObjects.User MapFromDto (this DataTransferObject.UserDto itemDto)
		{  
			if (itemDto == null) return null;
			
			return new DataObjects.User 
			{
					UserId = itemDto.UserId,
					Login = itemDto.Username,
					Created = itemDto.Created,
					Email = itemDto.Email,
			};
		}
	}
}

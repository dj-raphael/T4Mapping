

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
            
           var itemDto = new DataTransferObject.NewsDto ();
               itemDto.NewsId = item.NewsId;
               itemDto.Title = item.Title;
               itemDto.Anounce = item.Anounce;
               itemDto.Text = item.Text;
               itemDto.Status = item.Status.ToString();
               itemDto.Category = item.Category.MapToDto();
               itemDto.Created = item.Created;
               itemDto.Author = item.Author.Login;
               itemDto.Tags = item.NewsToTags.Select(p => p.Tag.Name);

           return itemDto;
        }

        public static DataObjects.News MapFromDto (this DataTransferObject.NewsDto itemDto)
        {  
            if (itemDto == null) return null;
            
            var item =  new DataObjects.News ();
                 item.NewsId = itemDto.NewsId.HasValue ? itemDto.NewsId.Value : default(System.Guid);
                 item.Title = itemDto.Title;
                 item.Anounce = itemDto.Anounce;
                 item.Text = itemDto.Text;
                 item.Status = (DataObjects.Attributes.StatusEnum) System.Enum.Parse(typeof(DataObjects.Attributes.StatusEnum), itemDto.Status);
                 item.Category = itemDto.Category.MapFromDto();
                 item.Created = itemDto.Created;
            
            return item;
        }
     
        public static DataTransferObject.CategoryDto MapToDto (this DataObjects.NewsCategory item)
        {  
           if (item == null) return null;
            
           var itemDto = new DataTransferObject.CategoryDto ();
               itemDto.NewsCategoryId = item.NewsCategoryId;
               itemDto.Name = item.Name;
               itemDto.ParentCategory = item.ParentCategory.MapToDto();
               itemDto.ChildCategories = item.ChildCategories.Select(x => x.MapToDto());

           return itemDto;
        }

        public static DataObjects.NewsCategory MapFromDto (this DataTransferObject.CategoryDto itemDto)
        {  
            if (itemDto == null) return null;
            
            var item =  new DataObjects.NewsCategory ();
                 item.NewsCategoryId = itemDto.NewsCategoryId;
                 item.Name = itemDto.Name;
                 item.ParentCategory = itemDto.ParentCategory.MapFromDto();
                 item.ChildCategories = itemDto.ChildCategories.Select(x => x.MapFromDto());
            
            return item;
        }
     
        public static DataTransferObject.UserDto MapToDto (this DataObjects.User item)
        {  
           if (item == null) return null;
            
           var itemDto = new DataTransferObject.UserDto ();
               itemDto.UserId = item.UserId;
               itemDto.Username = item.Login;
               itemDto.Created = item.Created;
               itemDto.Email = item.Email;

           return itemDto;
        }

        public static DataObjects.User MapFromDto (this DataTransferObject.UserDto itemDto)
        {  
            if (itemDto == null) return null;
            
            var item =  new DataObjects.User ();
                 item.UserId = itemDto.UserId;
                 item.Login = itemDto.Username;
                 item.Created = itemDto.Created;
                 item.Email = itemDto.Email;
            
            return item;
        }
     }
}
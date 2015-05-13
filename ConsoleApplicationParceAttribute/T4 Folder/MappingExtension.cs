

using System.Linq;

 namespace YumaPos.Server.BusinessLogic.Generation 
{ 
	 public static class MappingExtension
	 { 

//DataTransferObject.OrderFoodDto
//DataTransferObject.Product
//DataTransferObject.RestaurantOrderDto
//DataTransferObject.RoleDto
//DataTransferObject.TaxDto
//DataTransferObject.TransactionDto	
		public static DataTransferObject.AvailabilityDto MapToDto (this DataObjects.Availability item)
		{  
			if (item == null) return null;
			
			return new DataTransferObject.AvailabilityDto 
			{
					AvailabilityId =  trata2, 
					Days =  item.Days,
					TimeFrom =  item.TimeFrom,
					TimeTo =  item.TimeTo,
			};
		}

		public static DataObjects.Availability MapFromDto (this DataTransferObject.AvailabilityDto itemDto)
		{  
			if (itemDto == null) return null;
			
			return new DataObjects.Availability 
			{
					AvailabilityId =  tratata,
					Days =  itemDto.Days,
					TimeFrom =  itemDto.TimeFrom,
					TimeTo =  itemDto.TimeTo,
			};
		}
	
	
		public static DataTransferObject.KitchenDto MapToDto (this DataObjects.Kitchen item)
		{  
			if (item == null) return null;
			
			return new DataTransferObject.KitchenDto 
			{
					KitchenId =  item.KitchenId,
					Name =  item.Name,
			};
		}

		public static DataObjects.Kitchen MapFromDto (this DataTransferObject.KitchenDto itemDto)
		{  
			if (itemDto == null) return null;
			
			return new DataObjects.Kitchen 
			{
					KitchenId =  itemDto.KitchenId,
					Name =  itemDto.Name,
			};
		}
	
	
		public static DataTransferObject.OrderItemDto MapToDto (this DataObjects.OrderItem item)
		{  
			if (item == null) return null;
			
			return new DataTransferObject.OrderItemDto 
			{
					OrderId =  item.OrderId,
					MenuItemId =  item.MenuItemId,
			};
		}

		public static DataObjects.OrderItem MapFromDto (this DataTransferObject.OrderItemDto itemDto)
		{  
			if (itemDto == null) return null;
			
			return new DataObjects.OrderItem 
			{
					OrderId =  itemDto.OrderId,
					MenuItemId =  itemDto.MenuItemId,
			};
		}
	
	
		public static DataTransferObject.StoreDto MapToDto (this DataObjects.StoreTable item)
		{  
			if (item == null) return null;
			
			return new DataTransferObject.StoreDto 
			{
					Id =  item.Id,
					Name =  item.Name,
					ContactPerson =  item.ContactPerson,
					Email =  item.Email,
					Phone =  item.Phone,
					Url =  item.Url,
					Ip =  item.Ip,
					Country =  item.Country,
					State =  item.State,
					City =  item.City,
					PostalCode =  item.PostalCode,
					Address =  item.Address,
					Logo =  item.Logo,
					TimeShift =  item.TimeShift,
					TimeZone =  item.TimeZone,
					OpeningTime =  item.OpeningTime,
					IsActive =  item.IsActive,
			};
		}

		public static DataObjects.StoreTable MapFromDto (this DataTransferObject.StoreDto itemDto)
		{  
			if (itemDto == null) return null;
			
			return new DataObjects.StoreTable 
			{
					Id =  itemDto.Id,
					Name =  itemDto.Name,
					ContactPerson =  itemDto.ContactPerson,
					Email =  itemDto.Email,
					Phone =  itemDto.Phone,
					Url =  itemDto.Url,
					Ip =  itemDto.Ip,
					Country =  itemDto.Country,
					State =  itemDto.State,
					City =  itemDto.City,
					PostalCode =  itemDto.PostalCode,
					Address =  itemDto.Address,
					Logo =  itemDto.Logo,
					TimeShift =  itemDto.TimeShift,
					TimeZone =  itemDto.TimeZone,
					OpeningTime =  itemDto.OpeningTime,
					IsActive =  itemDto.IsActive,
			};
		}
	
	}
}

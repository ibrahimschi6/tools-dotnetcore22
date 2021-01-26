
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DotnetCore22.Domain.Model;
using DotnetCore22.DataAccess.Mapping;

namespace DotnetCore22.DataAccess
{
    public interface IDotnetCore22DBContext
    {
   

        IDbSet<AdminAuthority> AdminAuthorities { get; set; }
        IDbSet<AdminMenuItem> AdminMenuItems { get; set; }
        IDbSet<AdminRole> AdminRoles { get; set; }
        IDbSet<AdminUser> AdminUsers { get; set; }
        IDbSet<AutherizationSource> AutherizationSources { get; set; }
        IDbSet<Brand> Brands { get; set; }
        IDbSet<Buyer> Buyers { get; set; }
        IDbSet<City> Cities { get; set; }
        IDbSet<DailySalePrice> DailySalePrices { get; set; }
        IDbSet<Feedback> Feedbacks { get; set; }
        IDbSet<ListingAccessoryOption> ListingAccessoryOptions { get; set; }
        IDbSet<ListingInspactationCycleResult> ListingInspactationCycleResults { get; set; }
        IDbSet<ListingInspectationCheckItem> ListingInspectationCheckItems { get; set; }
        IDbSet<ListingInspectationCycle> ListingInspectationCycles { get; set; }
        IDbSet<ListingItemCondition> ListingItemConditions { get; set; }
        IDbSet<Listing> Listings { get; set; }
        IDbSet<ListingsComment> ListingsComments { get; set; }
        IDbSet<ListingsPhoto> ListingsPhotos { get; set; }
        IDbSet<ListingStateChange> ListingStateChanges { get; set; }
        IDbSet<ListingState> ListingStates { get; set; }
        IDbSet<ListingValidationCheckItem> ListingValidationCheckItems { get; set; }
        IDbSet<ListingValidationCycleResult> ListingValidationCycleResults { get; set; }
        IDbSet<ListingValidationCycle> ListingValidationCycles { get; set; }
        IDbSet<ModelColorOption> ModelColorOptions { get; set; }
        IDbSet<Model> Models { get; set; }
        IDbSet<ModelStorageOption> ModelStorageOptions { get; set; }
        IDbSet<Order> Orders { get; set; }
        IDbSet<OrderStateChange> OrderStateChanges { get; set; }
        IDbSet<OrderState> OrderStates { get; set; }
        IDbSet<RecentSold> RecentSolds { get; set; }
        IDbSet<Seller> Sellers { get; set; }
        IDbSet<User> Users { get; set; }
        IDbSet<UsersBlockedListing> UsersBlockedListings { get; set; }
        IDbSet<UsersFavoriteListing> UsersFavoriteListings { get; set; }

    }
}

namespace DotnetCore22.DataAccess
{
    public partial class DotnetCore22DBContext : DbContext, IDotnetCore22DBContext
    {
        static DotnetCore22DBContext()
        {
            Database.SetInitializer<DotnetCore22DBContext>(null);
        }

        public DotnetCore22DBContext()
            : base("Name=DotnetCore22DBContext")
        {
        }

        public IDbSet<AdminAuthority> AdminAuthorities { get; set; }
        public IDbSet<AdminMenuItem> AdminMenuItems { get; set; }
        public IDbSet<AdminRole> AdminRoles { get; set; }
        public IDbSet<AdminUser> AdminUsers { get; set; }
        public IDbSet<AutherizationSource> AutherizationSources { get; set; }
        public IDbSet<Brand> Brands { get; set; }
        public IDbSet<Buyer> Buyers { get; set; }
        public IDbSet<City> Cities { get; set; }
        public IDbSet<DailySalePrice> DailySalePrices { get; set; }
        public IDbSet<Feedback> Feedbacks { get; set; }
        public IDbSet<ListingAccessoryOption> ListingAccessoryOptions { get; set; }
        public IDbSet<ListingInspactationCycleResult> ListingInspactationCycleResults { get; set; }
        public IDbSet<ListingInspectationCheckItem> ListingInspectationCheckItems { get; set; }
        public IDbSet<ListingInspectationCycle> ListingInspectationCycles { get; set; }
        public IDbSet<ListingItemCondition> ListingItemConditions { get; set; }
        public IDbSet<Listing> Listings { get; set; }
        public IDbSet<ListingsComment> ListingsComments { get; set; }
        public IDbSet<ListingsPhoto> ListingsPhotos { get; set; }
        public IDbSet<ListingStateChange> ListingStateChanges { get; set; }
        public IDbSet<ListingState> ListingStates { get; set; }
        public IDbSet<ListingValidationCheckItem> ListingValidationCheckItems { get; set; }
        public IDbSet<ListingValidationCycleResult> ListingValidationCycleResults { get; set; }
        public IDbSet<ListingValidationCycle> ListingValidationCycles { get; set; }
        public IDbSet<ModelColorOption> ModelColorOptions { get; set; }
        public IDbSet<Model> Models { get; set; }
        public IDbSet<ModelStorageOption> ModelStorageOptions { get; set; }
        public IDbSet<Order> Orders { get; set; }
        public IDbSet<OrderStateChange> OrderStateChanges { get; set; }
        public IDbSet<OrderState> OrderStates { get; set; }
        public IDbSet<RecentSold> RecentSolds { get; set; }
        public IDbSet<Seller> Sellers { get; set; }
        public IDbSet<User> Users { get; set; }
        public IDbSet<UsersBlockedListing> UsersBlockedListings { get; set; }
        public IDbSet<UsersFavoriteListing> UsersFavoriteListings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdminAuthorityMap());
            modelBuilder.Configurations.Add(new AdminMenuItemMap());
            modelBuilder.Configurations.Add(new AdminRoleMap());
            modelBuilder.Configurations.Add(new AdminUserMap());
            modelBuilder.Configurations.Add(new AutherizationSourceMap());
            modelBuilder.Configurations.Add(new BrandMap());
            modelBuilder.Configurations.Add(new BuyerMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new DailySalePriceMap());
            modelBuilder.Configurations.Add(new FeedbackMap());
            modelBuilder.Configurations.Add(new ListingAccessoryOptionMap());
            modelBuilder.Configurations.Add(new ListingInspactationCycleResultMap());
            modelBuilder.Configurations.Add(new ListingInspectationCheckItemMap());
            modelBuilder.Configurations.Add(new ListingInspectationCycleMap());
            modelBuilder.Configurations.Add(new ListingItemConditionMap());
            modelBuilder.Configurations.Add(new ListingMap());
            modelBuilder.Configurations.Add(new ListingsCommentMap());
            modelBuilder.Configurations.Add(new ListingsPhotoMap());
            modelBuilder.Configurations.Add(new ListingStateChangeMap());
            modelBuilder.Configurations.Add(new ListingStateMap());
            modelBuilder.Configurations.Add(new ListingValidationCheckItemMap());
            modelBuilder.Configurations.Add(new ListingValidationCycleResultMap());
            modelBuilder.Configurations.Add(new ListingValidationCycleMap());
            modelBuilder.Configurations.Add(new ModelColorOptionMap());
            modelBuilder.Configurations.Add(new ModelMap());
            modelBuilder.Configurations.Add(new ModelStorageOptionMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new OrderStateChangeMap());
            modelBuilder.Configurations.Add(new OrderStateMap());
            modelBuilder.Configurations.Add(new RecentSoldMap());
            modelBuilder.Configurations.Add(new SellerMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UsersBlockedListingMap());
            modelBuilder.Configurations.Add(new UsersFavoriteListingMap());
        }
    }
}






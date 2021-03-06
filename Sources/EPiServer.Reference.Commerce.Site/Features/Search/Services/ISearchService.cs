using EPiServer.Core;
using EPiServer.Reference.Commerce.Site.Features.Product.ViewModels;
using EPiServer.Reference.Commerce.Site.Features.Search.Models;
using EPiServer.Reference.Commerce.Site.Features.Search.ViewModels;
using System.Collections.Generic;

namespace EPiServer.Reference.Commerce.Site.Features.Search.Services
{
    public interface ISearchService
    {
        CustomSearchResult Search(IContent currentContent, FilterOptionViewModel filterOptions);
        IEnumerable<ProductViewModel> QuickSearch(string query);
        IEnumerable<ProductViewModel> QuickSearch(FilterOptionViewModel filterOptions);
        IEnumerable<SortOrder> GetSortOrder();
    }
}
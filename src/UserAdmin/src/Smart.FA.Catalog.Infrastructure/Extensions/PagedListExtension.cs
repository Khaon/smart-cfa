﻿using Microsoft.EntityFrameworkCore;
using Smart.FA.Catalog.Core.SeedWork;
using Smart.FA.Catalog.Shared.Collections;

namespace Smart.FA.Catalog.Infrastructure.Extensions;

public static class PagedListExtension
{
    public static async Task<PagedList<T>> PaginateAsync<T>(this IQueryable<T> source, PageItem pageItem, CancellationToken cancellationToken = default)
    {
        var count = await source.CountAsync(cancellationToken);
        var items = await source.Skip(pageItem.Offset).Take(pageItem.PageSize).ToListAsync(cancellationToken);
        return new PagedList<T>(items, pageItem, count);
    }

    public static PagedList<Entity> ToPagedListOfEntities<T>(this PagedList<T> pagedList) where T : Entity
    => new(pagedList, new PageItem(pagedList.CurrentPage, pagedList.PageSize), pagedList.TotalCount);
}

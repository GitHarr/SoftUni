namespace PhotoShare.Services
{
    using Models;
    using Contracts;
    using System.Collections.Generic;
    using System;
    using Data;
    using System.Linq;
    using AutoMapper.QueryableExtensions;

    public class AlbumTagService : IAlbumTagService
    {
        private readonly PhotoShareContext context;

        public AlbumTagService(PhotoShareContext context)
        {
            this.context = context;
        }

        public AlbumTag AddTagTo(int albumId, int tagId)
        {
            var albumTag = new AlbumTag
            {
                AlbumId = albumId,
                TagId = tagId
            };

            this.context.AlbumTags.Add(albumTag);

            this.context.SaveChanges();

            return albumTag;
        }
    }
}

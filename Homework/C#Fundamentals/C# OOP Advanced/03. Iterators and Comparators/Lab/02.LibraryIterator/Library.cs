﻿using System;
using System.Collections;
using System.Collections.Generic;

public class Library : IEnumerable<Book>
{
    private List<Book> books;

    public Library(params Book[] books)
    {
        this.books = new List<Book>(books);
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return new LibraryIterator(books);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private class LibraryIterator : IEnumerator<Book>
    {
        public Book Current => books[index];

        object IEnumerator.Current => Current;

        private IReadOnlyList<Book> books;
        private int index;

        public LibraryIterator(IReadOnlyList<Book> books)
        {
            this.books = books;
            index = -1;
        }

        public void Dispose() { }

        public bool MoveNext()
        {
            index++;
            return index < books?.Count;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}


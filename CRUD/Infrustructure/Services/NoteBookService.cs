using Domain.Models;

namespace Infrustructure.Services;

public class NoteBookService
{
    List<NoteBook> notes= new List<NoteBook>();
    public  List<NoteBook> GetAll()
    {
        return notes;
    }
    public NoteBook GetById(int id)
    {
        var noteBook = notes.FirstOrDefault(p => p.Id == id);
        return noteBook;
    }
    public void Create(NoteBook noteBook)
    {
        notes.Add(noteBook);
    }
    public void Update(int id)
    {
        var noteBook = notes.FirstOrDefault(p => p.Id == id);
    }
    public void Delete(int id)
    {
        var noteBook = notes.FirstOrDefault(p => p.Id == id);
        notes.Remove(noteBook);
    }
     
}

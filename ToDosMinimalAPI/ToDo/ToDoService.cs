﻿namespace ToDosMinimalAPI;

public class ToDoService : IToDoService
{
    public ToDoService()
    {
        var sampleToDo = new ToDo { Value = "Learn MinimalAPI" };
        _toDos[sampleToDo.Id] = sampleToDo;
    }
    private readonly Dictionary<Guid, ToDo> _toDos = new();

    public ToDo GetById(Guid id)
    {
        return _toDos.GetValueOrDefault(id);
    }
    public List<ToDo> GetAll()
    {
        return _toDos.Values.ToList();
    }
    public void Create(ToDo toDo)
    {
        if (toDo == null)
        {
            return;
        }
        _toDos[toDo.Id] = toDo;
    }

    public void Update(ToDo toDo)
    {
        var existingToDo = GetById(toDo.Id);
        if (existingToDo == null)
        {
            return;
        }
        _toDos[toDo.Id] = toDo;
    }
    public void Delete(Guid id)
    {
        _toDos.Remove(id);
    }
}


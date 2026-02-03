# Описание плагина

Плагин отображает все уровни в документе, а также позволяет создавать, удалять или редактировать уровни

---
# Описание логики работы плагина

1) Метод Execute плагина Levels Property через ExternalCommandData получает необходимые ссылки
2) FilteredElementCollector получает список уровней из документа
```C#
FilteredElementCollector collector = new FilteredElementCollector(m_revit.Application.ActiveUIDocument.Document);

ICollection<Element> collection = collector.OfClass(typeof(Level)).ToElements();
```
3) Список collection перебирается в цикле foreach и для каждого Level создается объект пользовательского класса LevelDataSource(необходим для понятного отображения в интерфейсе Revit), который заполняется данными из Level и добавляется в коллекцию systemLevelsDatum
```C#
foreach (Element element in collection)
{
     Level systemLevel = element as Level;
     LevelsDataSource levelsDataSourceRow = new LevelsDataSource();

     levelsDataSourceRow.LevelIDValue = systemLevel.Id.IntegerValue;
     levelsDataSourceRow.Name = systemLevel.Name;

     Parameter elevationPara = systemLevel.get_Parameter(BuiltInParameter.LEVEL_ELEV);
     
     double temValue = Unit.CovertFromAPI(UnitType, elevationPara.AsDouble());
     double temValue2 = double.Parse(temValue.ToString("#.0"));
     
     levelsDataSourceRow.Elevation = temValue2;

     systemLevelsDatum.Add(levelsDataSourceRow);
}
```
4) Создается экземпляр диалогового окна LevelsForm в котором отображаются элементы коллекции systemLevelsDatum
```C#
using (LevelsForm displayForm = new LevelsForm(this))
{
	displayForm.ShowDialog();
}
```

# Описание интерфейса IMaterial
Интерфейс предназначен для работы с методами класса Material

## Реализация интерфейса
* +Add (Material:[Material](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Material.md "объект класса Material")): Int — функция, добавляющая материал в базу данных. Параметр «[Material](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Material.md "объект класса Material")» — материал, 
который необходимо добавить в БД;
* +Save ([Material](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Material.md "объект класса Material")): Bool — функция, редактирующая данные о материале. Параметр «[Material](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Material.md "объект класса Material")» — 
материал, который необходимо редактировать в БД;
* +FindByID(ID: Int): [Material](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Material.md "объект класса Material")  — функция, осуществляющая поиск материала в базе данных по ID и возвращающая найденный, если такой есть. 
* +Delete(ID): Bool – функция удаляет материал.
* +GetAllMaterials(sorting: string, sortingA: string, filtering: Reader, count: Int, page: Int): List <[Material](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Material.md "объект класса Material")> — функция, возвращающая список материалов. 
Параметры: 
	* sortintg: string — отвечает, по какому полю будет сортироваться список;
  
	* sortingA: bool — отвечает, по возрастанию или убыванию будут сортироваться элементы;
  
	* filtering: string — отвечает за фильтрацию;
  
	* count: int — отвечает, сколько элементов необходимо показать;
  
	* page: int — отвечает, с какой страницы начинать поиск элементов.
* +GetAmountInBranch(MaterialID: Int): Dictionary <[Branch](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Branch.md "объект класса Branch"),Double> — функция, возвращающая словарь с ключом филиала и значением остатка.
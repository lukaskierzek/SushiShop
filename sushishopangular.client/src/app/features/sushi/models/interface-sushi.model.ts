export interface ISushi {
  id: number,
  name: string,
  actualPrice: number,
  oldPrice: number
  description: string,
  mainCategory: string,
  imageUrl: string,
  ingredients: IIngredietent[],
  subCategories: ISubCategories[],
}

interface IIngredietent {
  id: number,
  name: string,
  amount: number,
}

interface ISubCategories {
  id: number,
  name: string,
}

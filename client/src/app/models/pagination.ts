import { IProduct } from './product';

export interface IPagination {
  pageInd: number;
  pageSize: number;
  count: number;
  data: IProduct[];
}



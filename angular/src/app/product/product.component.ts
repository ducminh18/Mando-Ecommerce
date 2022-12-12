import { PagedResultDto } from '@abp/ng.core/public-api';
import { Component, OnInit, OnDestroy } from '@angular/core';
import { ProductsService } from '../proxy/products/products.service';
import { ProductInListDto } from '../proxy/products/models';
import { Subject, takeUntil } from 'rxjs';
import { ProductCategoryInListDto } from '../proxy/product-categories/models';
import { ProductCategoriesService } from '../proxy/product-categories/product-categories.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.scss'],
})
export class ProductComponent implements OnInit, OnDestroy {
  private ngUnsubscribe = new Subject<void>();
  blockedPanel: boolean = false;
  items: ProductInListDto[] = [];
  
  // Page variables
  public skipCount: number = 0;
  public maxResultCount: number = 10;
  public totalCount: number;

  //Filter
  productCategories: any[] = [];
  keyword: string ='';
  categoryId: string = '';

  constructor(private ProductsService:  ProductsService, private productCategoriesService: ProductCategoriesService) {}
  ngOnDestroy(): void {
    this.ngUnsubscribe.next();
    this.ngUnsubscribe.complete();
  }
  ngOnInit(): void {
    this.loadProductCategories();
    this.loadData();
  }

  loadData(){
    this.ProductsService
    .getListFilter({
      keyword: this.keyword,
      categoryId: this.categoryId,
      maxResultCount: this.maxResultCount,
      skipCount: this.skipCount
    })
    .pipe(takeUntil(this.ngUnsubscribe))
    .subscribe({
      next: (response: PagedResultDto<ProductInListDto>) => {
        this.items = response.items;
        this.totalCount = response.totalCount;
      },
      error: () => {},
    });
  }

  loadProductCategories() {
    this.productCategoriesService.getListAll()
    .subscribe((response: ProductCategoryInListDto[]) => {
      response.forEach(element =>{
        this.productCategories.push({
          value: element.id,
          name: element.name
        })
      })
    });
  }

  pageChanged(event: any) :void {
    this.skipCount = (event.page - 1) * this.maxResultCount;
    this.maxResultCount = event.rows;
    this.loadData();
  }
}

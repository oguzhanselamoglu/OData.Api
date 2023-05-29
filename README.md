# OData.Api

# Select
Geriye dönüş propertylerini ifade eder
http://localhost:5049/odata/products?$select=Id,Name

# Expand
entity üzerindeki navigation propertyi dahil etmeye yarar

http://localhost:5049/odata/products?$expand=category

# orderby
entity üzerinde sıralama işlemi yapılabilir

http://localhost:5049/odata/products?$orderby=Id desc,Name desc


http://localhost:5049/odata/products?$select=Id,Name&$expand=category
http://localhost:5049/odata/products?$select=Id,Name&$expand=category($select=Name)

# top,count,skip
http://localhost:5049/odata/products?$top=10&#select=Id,Name
http://localhost:5049/odata/products?$skip=2&top=10&#select=Id,Name
http://localhost:5049/odata/products?$count=true

# filter
Entity üerindeki filtreleme işlemi

= (Equal)
http://localhost:5049/odata/products?$filter=name eq 'ayran'

!= (Not Equal)
http://localhost:5049/odata/products?$filter=stock ne 10

> (Greather Than)
http://localhost:5049/odata/products?$filter=stock gt 10

>= (Greather Equeal)
http://localhost:5049/odata/products?$filter=stock ge 10

< (Less Than)
http://localhost:5049/odata/products?$filter=stock lt 10

<= (Less Equeal)
http://localhost:5049/odata/products?$filter=stock le 10
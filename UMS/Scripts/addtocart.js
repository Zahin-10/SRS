function addtocart(id, name, price) {
    var mycart = [];
    if (Cookies.get('cart') != null) {
        mycart = JSON.parse(Cookies.get('cart'));

        console.log(mycart);
    }
    if (mycart.length > 0)
    {
        flag = 0;
        $.each(mycart,function(index, value)
        {
            if (value.itemId == parseInt(id))
            {
                value.quantity += 1;
                Cookies.set('cart', JSON.stringify(mycart));
                console.log(JSON.parse(Cookies.get('cart')));
                flag = 1;
            }
        });
        if (flag != 1)
        {
            var item =
            {
                itemId: parseInt(id),
                name: name,
                price: parseFloat(price),
                quantity: 1
            }
            mycart.push(item);
            Cookies.set('cart', JSON.stringify(mycart));
            console.log(JSON.parse(Cookies.get('cart')));
        }
    }
    else
    {
        var item =
        {
            itemId: parseInt(id),
            name: name,
            price: parseFloat(price),
            quantity: 1
        }
        cartitems.push(item);
        Cookies.set('cart', JSON.stringify(cartitems));
        console.log(JSON.parse(Cookies.get('cart')));
    }
    

}
import { createContext, PropsWithChildren, useContext, useState } from "react";
import { Cart } from "../model/ICart";

interface CartContextValue {
    cart : Cart | null;
    setCart : (cart: Cart) => void;
}

// eslint-disable-next-line react-refresh/only-export-components
export const CartContext = createContext<CartContextValue | undefined>(undefined);

// eslint-disable-next-line react-refresh/only-export-components
export function useCartContext() {
    const context = useContext(CartContext);
    if(context == undefined) {
        throw new Error("no provider");
    }
    return context;
}

// eslint-disable-next-line @typescript-eslint/no-explicit-any
export function CartContextProvider({children}: PropsWithChildren<any>) {
    const [cart, setCart] = useState<Cart | null>(null);

    return (
        <CartContext.Provider value={{cart, setCart}}>
            {children}
        </CartContext.Provider>
    );
}
export { default } from "next-auth/middleware"
export const config={
    matcher:['/session'],
    pages:'/api/auth/signin'
}
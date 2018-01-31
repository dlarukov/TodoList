import Vue from 'vue'
import Router from 'vue-router'
import Main from '@/views/Main'
import NotFound from '@/views/NotFound'

Vue.use(Router)

export default new Router({
  mode: 'history',
  routes: [
    {
      path: '/',
      name: 'Main',
      component: Main
    },
    {
      path: '*',
      name: 'NotFound',
      component: NotFound
    }
  ]
})

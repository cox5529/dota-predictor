import React from 'react';

import cx from 'classnames';

import { HeroResponse } from '../api';
import HeroListHeroTeamSelector from './HeroListHeroTeamSelector';
import HeroImage from './HeroImage';

type HeroListHeroProps = {
  hero: HeroResponse;
  onSelection: (hero: HeroResponse, isRadiant: boolean) => void;
};

const HeroListHero: React.FC<HeroListHeroProps> = ({ hero, onSelection }: HeroListHeroProps) => {
  return (
    <HeroImage className='flex' hero={hero}>
      <HeroListHeroTeamSelector radiant={true} onClick={() => onSelection(hero, true)} />
      <HeroListHeroTeamSelector radiant={false} onClick={() => onSelection(hero, false)} />
    </HeroImage>
  );
};

export default HeroListHero;
